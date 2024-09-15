using System.IO;

namespace Cerberus.Cerberus.Helpers
{
    internal static class StringHelpers
    {
        public static string RemoveInvalidChars(this string fileName)
        {
            if (fileName.IsNullOrWhiteSpace())
            {
                return null;
            }

            return string.Join(string.Empty, fileName.Split(Path.GetInvalidFileNameChars()));
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static string GetChangelogHtml()
        {
            return @"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Change Log</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        line-height: 1.6;
                        margin: 0;
                        padding: 0;
                        background-color: #f4f4f4;
                    }
                    .container {
                        width: 80%;
                        margin: 20px auto;
                        background: #fff;
                        padding: 20px;
                        border-radius: 8px;
                        box-shadow: 0 0 10px rgba(0,0,0,0.1);
                    }
                    h1 {
                        color: #333;
                        border-bottom: 2px solid #007bff;
                        padding-bottom: 10px;
                        margin-bottom: 20px;
                    }
                    .entry {
                        margin-bottom: 20px;
                    }
                    .date {
                        font-weight: bold;
                        color: #555;
                    }
                    .changes {
                        margin-top: 5px;
                    }
                    .list {
                        list-style: none;
                        padding: 0;
                    }
                    .list-item {
                        background: #e9ecef;
                        margin: 5px 0;
                        padding: 10px;
                        border-radius: 4px;
                    }
                </style>
            </head>
            <body>
                <div class='container'>
                    <h1>Change Log</h1>
                    <div class='entry'>
                        <div class='date'>2024-09-14</div>
                        <div class='changes'>
                            <ul class='list'>
                                <li class='list-item'>Added HTML support to display changelog.</li>
                                <li class='list-item'>Updated DevExpress MemoEdit with styled HTML content.</li>
                            </ul>
                        </div>
                    </div>
                    <div class='entry'>
                        <div class='date'>2024-09-13</div>
                        <div class='changes'>
                            <ul class='list'>
                                <li class='list-item'>Fixed SQL Server connection issues.</li>
                                <li class='list-item'>Improved user interface for login functionality.</li>
                            </ul>
                        </div>
                    </div>
                    <!-- Add more entries here -->
                </div>
            </body>
            </html>";
        }
    }
}
