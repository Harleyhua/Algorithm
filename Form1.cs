using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel; // 引入ClosedXML的命名空间
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using ZXing; // 条形码生成库
using ZXing.Common;
using ZXing.QrCode.Internal;


namespace Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string CustomAlgorithm(string input)
        {
            if (input.Length != 8)
            {
                throw new ArgumentException("Input string must be 8 characters long");
            }

            int[] fixedValues = { 3, 5, 7, 11, 13, 17, 19, 23 };
            int initialVector = 0;
            foreach (char c in input)
            {
                initialVector += c;
            }

            char[] result = new char[8];
            for (int i = 0; i < 8; i++)
            {
                char char1 = input[i];
                char char2 = input[7 - i];
                int ascii1 = (int)char1;
                int ascii2 = (int)char2;
                int transformedValue;
                switch ((i + initialVector) % 4)
                {
                    case 0:
                        transformedValue = (ascii1 | ascii2) + fixedValues[i];
                        break;
                    case 1:
                        transformedValue = (ascii1 & ascii2) + fixedValues[(i + initialVector) % 8];
                        break;
                    case 2:
                        transformedValue = (ascii1 ^ ascii2) + fixedValues[(i + initialVector * 2) % 8];
                        break;
                    default:
                        transformedValue = ascii1 + fixedValues[(i + initialVector * 3) % 8];
                        break;
                }
                int modValue = transformedValue % 62;
                if (modValue < 10)
                {
                    result[i] = (char)(modValue + '0');
                }
                else if (modValue < 36)
                {
                    result[i] = (char)(modValue - 10 + 'A');
                }
                else
                {
                    result[i] = (char)(modValue - 36 + 'a');
                }
            }
            return new string(result);
        }

        private void SN_GenerateBarcodeImage(string content, string filePath)
        {
            // 创建条形码写入器
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128, // 选择条形码格式
                Options = new EncodingOptions
                {
                    Width = 250, // 条形码宽度
                    Height = 100 // 条形码高度
                }
            };
            var barcode = writer.Write(content);
            barcode.Save(filePath);
        }

        //private void PW_GenerateBarcodeImage(string content, string filePath)
        //{
        //    // 创建条形码写入器
        //    var writer = new BarcodeWriter
        //    {
        //        Format = BarcodeFormat.CODE_128, // 选择条形码格式
        //        Options = new EncodingOptions
        //        {
        //            Width = 250, // 条形码宽度
        //            Height = 100 // 条形码高度
        //        }
        //    };
        //    var barcode = writer.Write(content);
        //    barcode.Save(filePath);
        //}

        private void SN_DisplayBarcodeImage(string imagePath)
        {

             // 清空PictureBox的现有图像
             SN_pictureBox.Image = null;
             // 使用using块确保图像资源被及时释放
             Bitmap barcodeImage = new Bitmap(imagePath);
             SN_pictureBox.Image = barcodeImage;
             SN_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
             SN_pictureBox.Invalidate(); // 重新绘制PictureBox以显示新图像

        }

        //private void PW_DisplayBarcodeImage(string imagePath)
        //{
        //    PW_pictureBox.Image = null;

        //    Bitmap barcodeImage = new Bitmap(imagePath);
        //    //Image barcodeImage = Image.FromFile(imagePath);
        //    PW_pictureBox.Image = barcodeImage;
        //    PW_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        //    PW_pictureBox.Invalidate();
        //}

        // 生成随机文件名
        string GenerateRandomFileName()
        {
            // 使用Guid生成一个随机字符串，然后去掉其中的连字符并转换为小写  
            string randomString = Guid.NewGuid().ToString("N").ToLower();
            // 假设我们只想要前8个字符作为文件名  
            return randomString.Substring(0, Math.Min(randomString.Length, 4));
        }

        public void GenerateQRCode(string content, string filePath)
        {
            //创建二维码写入器
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 250, // 二维码宽度
                    Height = 250, // 二维码高度
                    Margin = 10, // 二维码周围的空白边距
                }
            };
            // 设置QRCode特定的编码选项
            writer.Options.Hints[EncodeHintType.ERROR_CORRECTION] = ErrorCorrectionLevel.H;

            // 生成二维码图像
            using (Bitmap bitmap = writer.Write(content))
            {
                bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void QRC_DisplayBarcodeImage(string imagePath)
        {
            QRC_pictureBox.Image = null;

            Bitmap barcodeImage = new Bitmap(imagePath);
            //Image barcodeImage = Image.FromFile(imagePath);
            QRC_pictureBox.Image = barcodeImage;
            QRC_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            QRC_pictureBox.Invalidate();
        }

        private void num_btnTransform_Click(object sender, EventArgs e)
        {
            if (int.TryParse(number.Text, out int loopCount) && loopCount > 0)
            {
                // 用于存储转换结果的列表
                List<string> results = new List<string>();
                string currentNumber = txtInput.Text;

                // 检查输入的首位是否是字母，如果是，则检查是否为大写
                if (char.IsLetter(currentNumber, 0) && !char.IsUpper(currentNumber[0]))
                {
                    MessageBox.Show("请输入大写字母！");
                    return;
                }
                txtResults.Clear(); 

                if (loopCount == 1)
                    {
                        try
                        {
                            string input = txtInput.Text;
                            string result = CustomAlgorithm(input);
                            lblResult.Text = result;
                            string resultLine = $"{currentNumber} -> {result}";
                            results.Add(resultLine);
                            txtResults.AppendText(resultLine + "\n\r");

                            string QRC = input + result;
                            // 根据输入文本生成条形码
                            string snFileName = $"S{GenerateRandomFileName()}.png";
                            SN_GenerateBarcodeImage(input, snFileName);
                            SN_DisplayBarcodeImage(snFileName);
                            //// 根据算法结果生成条形码
                            //string pwFileName = $"P{GenerateRandomFileName()}.png";
                            //PW_GenerateBarcodeImage(result, pwFileName);
                            //PW_DisplayBarcodeImage(pwFileName);

                            string QRCFileName = $"Q{GenerateRandomFileName()}.png";
                            GenerateQRCode(QRC, QRCFileName);
                            QRC_DisplayBarcodeImage(QRCFileName);

                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                        // 显示询问框
                        DialogResult dialogResult = MessageBox.Show("是否导出Excel表？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            //导出到Excel
                            ExportToExcel_xls(results);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("已取消导出Excel表！");
                        }
                }
                else {
                    for (int i = 0; i < loopCount; i++)
                    {
                        string transformedResult = CustomAlgorithm(currentNumber);
                        string resultLine = $"{currentNumber} -> {transformedResult}";
                        results.Add(resultLine);
                        txtResults.AppendText(resultLine + "\n\r");
                        //当前编号递增
                        IncrementNumber(ref currentNumber);
                    }
                    txtResults.SelectionStart = txtResults.Text.Length;
                    txtResults.ScrollToCaret();

                    ExportToExcel_xls(results);
                }
                }
            else
            {
                MessageBox.Show("请输入整数！");
            }
        }
        private void IncrementNumber(ref string number)
        {
            // 从最低位开始递增
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] == '9')
                {
                    number = number.Substring(0, i) + '0' + number.Substring(i + 1);
                }
                else
                {
                    char incrementedChar = (char)((number[i] - '0') + 1 + '0');
                    number = number.Substring(0, i) + incrementedChar + number.Substring(i + 1);
                    break; // 退出循环
                }
            }
        }

        private void ExportToExcel(List<string> results)
        {
            try
            {
                // 创建新的Excel工作簿
                XLWorkbook workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Converted Results");

                // 设置字段名
                worksheet.Cell(1, 1).Value = "编号";

                // 开始行号
                int row = 2; 
                foreach (string result in results)
                {
                    string[] parts = result.Split(' ');
                    string cellValue = "S/N:" + parts[0] + Environment.NewLine + "PW:" + parts[2];
                    worksheet.Cell(row, 1).Value = cellValue;
                    row++;
                }

                // 设置所有列宽为13.80
                for (int col = 1; col <= row; col++) // 根据需要设置列的范围
                {
                    worksheet.Column(col).Width = 13.80;
                }

                // 保存工作簿
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    DefaultExt = "xlsx",
                    AddExtension = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("导出Excel成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出Excel出错：" + ex.Message);
            }
        }

        public void ExportToExcel_xls(List<string> results)
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Converted Results") as ISheet;

            //标题行
            IRow headerRow = sheet.CreateRow(0) as IRow;
            headerRow.CreateCell(0).SetCellValue("二维码");
            //headerRow.CreateCell(1).SetCellValue("密码");
            //headerRow.CreateCell(2).SetCellValue("二维码");


            //foreach (string result1 in results)
            //{
            //    string[] parts = result1.Split(' ');
            //    if (parts.Length >= 3)
            //    {
            //        IRow sheetRow = sheet.GetRow(row) ?? sheet.CreateRow(row);
            //        ICell cell = sheetRow.GetCell(0) ?? sheetRow.CreateCell(0);
            //        StringBuilder noteString = new StringBuilder("S/N:" + parts[0] + "\n");
            //        noteString.Append("PW:" + parts[2]);
            //        cell.SetCellValue(noteString.ToString());
            //        // 创建样式并设置换行  
            //        ICellStyle notesStyle = workbook.CreateCellStyle();
            //        notesStyle.WrapText = true;
            //        cell.CellStyle = notesStyle;
            //        row++;
            //    }
            //}
            //foreach (string result1 in results)
            //{
            //    string[] parts = result1.Split(' ');
            //    if (parts.Length >= 2)
            //    {
            //        IRow sheetRow = sheet.GetRow(row) ?? sheet.CreateRow(row) as IRow;
            //        //微逆ID
            //        sheetRow.CreateCell(0).SetCellValue(parts[0].Trim());
            //        //密码
            //        sheetRow.CreateCell(1).SetCellValue(parts[2].Trim());
            //        //二维码 
            //        sheetRow.CreateCell(2).SetCellValue(parts[0] + ";" + parts[2]);
            //        row++;
            //    }
            //}
            int row = 1;
            foreach (string result1 in results)
            {
                string[] parts = result1.Split(' ');
                if (parts.Length >= 2)
                {
                    IRow sheetRow = sheet.GetRow(row) ?? sheet.CreateRow(row);
                    sheetRow.CreateCell(0).SetCellValue(parts[0] + ";" + parts[2]);
                    row++;
                }
            }

            // 列宽
            sheet.SetColumnWidth(0, 20 * 256); // 微逆ID
            //sheet.SetColumnWidth(1, 11 * 256); // 密码
            //sheet.SetColumnWidth(2, 20 * 256); // 二维码

            //行高
            double rowHeight = 15 * 20; 
            for (int i = 1; i < row; i++)
            {
                IRow currentRow = sheet.GetRow(i) ?? sheet.CreateRow(i) as IRow;
                currentRow.Height = (short)rowHeight;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xls", 
                DefaultExt = "xls", 
                AddExtension = true, 
                Title = "保存Excel文件", 
                FileName = "文件名.xls" 
            };

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(file);
                    }

                    MessageBox.Show("Excel表导出成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存文件时出错: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("保存操作已取消！");
            }
        }
    }

}
