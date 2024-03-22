namespace CommonComponents
{
    internal interface IAccessTypeEventArgs
    {
        AccessTypeEventArgs.AccessType AccessTypeValue { get; set; }
        bool ValuesWereChanged { get; set; }
    }
}