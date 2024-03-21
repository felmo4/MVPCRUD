﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public class DataAccessStatus
    {
        public string Status { get; set; }
        public bool OperationSucceeded { get; set; }
        public string ExceptionMessage { get; set; }
        public string CustomMessage { get; set; }
        public string HelpLink { get; set; }
        public int ErrorCode { get; set; }
        public string StackTrace { get; set; }

        public void setValues(string status, bool operationSucceeded, string exceptionMessage, string customMessage, string helpLink, int errorCode, string stackTrace)
        {
            Status = status ?? string.Copy("");
            OperationSucceeded = operationSucceeded;
            ExceptionMessage = exceptionMessage ?? string.Copy("");
            CustomMessage = customMessage ?? string.Copy("");
            HelpLink = helpLink ?? string.Copy("");
            ErrorCode = errorCode;
            StackTrace = stackTrace ?? string.Copy("");
        }
        public string GetFormattedValues()
        {
            return $"Status--> {Status}\n" +
                $"OperationSucceeded--> {OperationSucceeded}\n" +
                $"ExceptionMessage--> {ExceptionMessage}\n" +
                $"CustomMessage--> {CustomMessage}\n" +
                $"HelpLink--> {HelpLink}\n" +
                $"ErrorCode--> {ErrorCode}\n" +
                $"StackTrace--> {StackTrace}";
        }
    }
}
