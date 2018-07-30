using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToDbApplication
{
    class ExcelManager
    {

        public struct ExcelReadParam
        {
            public String sFileName;
            public String sDirectory;

            public String getCombine()
            {
                return sDirectory + sFileName;
            }
        }

        public struct ExcelOutputParam
        {
            public DatabaseManager.CreateTableParam tCreateTableParamRes;
            public List<DatabaseManager.AddTableItemContentParam> vsAddTableItemContentParamRes;
        }

        public ExcelOutputParam OpenExcelFile(ExcelReadParam tInputParam)
        {
            //Output Buffer
            ExcelOutputParam tResult;

            //Table Creation
            DatabaseManager.CreateTableParam tTableParam;
            tTableParam.sTableName = tInputParam.sFileName;
            tTableParam.vsFields = new List<DatabaseManager.TableFieldParam>();

            //Allocate list content
            tResult.vsAddTableItemContentParamRes = new List<DatabaseManager.AddTableItemContentParam>();

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;


            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@tInputParam.getCombine(), 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            DatabaseManager.TableFieldParam tTableFieldParam;
            //get fields name
            for (cCnt = 1; cCnt <= cl; cCnt++) {
                // Row 1
                tTableFieldParam.sName = Convert.ToString(range.Cells[1, cCnt].Value2);
                tTableFieldParam.eDataType = DatabaseManager.FIELDS_DATATYPE.CHAR_ITEM;

                // Add fields
                tTableParam.vsFields.Add(tTableFieldParam);
            }

            //get content
            //Table Content
            DatabaseManager.AddTableItemContentParam tTableContentItems;
            DatabaseManager.TableContent tTableContent;
            
            for (rCnt = 2; rCnt <= rw; rCnt++) {
                tTableContentItems.vsTableContent = new List<DatabaseManager.TableContent>();

                for (cCnt = 1; cCnt <= cl; cCnt++) {
                    // Get Content
                    tTableContent.eDataType = DatabaseManager.FIELDS_DATATYPE.CHAR_ITEM;
                    tTableContent.FieldName = Convert.ToString(range.Cells[1, cCnt].Value2);
                    tTableContent.FieldContent = Convert.ToString(range.Cells[rCnt, cCnt].Value2);

                    //get table content
                    tTableContentItems.vsTableContent.Add(tTableContent);
                }

                tTableContentItems.sTableName = tInputParam.sFileName;
                tResult.vsAddTableItemContentParamRes.Add(tTableContentItems);
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            //Get result
            tResult.tCreateTableParamRes = tTableParam;

            return tResult;
        }
    }
}
