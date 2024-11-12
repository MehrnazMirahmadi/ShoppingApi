namespace Framework.Domain
{
    public class OperationResult
    {
        public int StatusCode { get; set; }
        public int? RecordID { get; set; }
        public string Message { get; private set; }
        public string DomainName { get; private set; }
        public bool Success { get; private set; }
        public DateTime OperationDate { get; private set; }
        public OperationResult(string DomainName)
        {
            Success = false;
            OperationDate = DateTime.Now;
            this.DomainName = DomainName;
        }
        public OperationResult ToSuccess(string Message, int RecordID = -1)
        {
            this.Success = true;
            this.Message = Message;
            this.RecordID = RecordID;
            return this;
        }

        public OperationResult ToFail(string Message, int RecordID = -1)
        {
            this.RecordID = RecordID;
            this.Message = Message;
            return this;
        }


    }
}
