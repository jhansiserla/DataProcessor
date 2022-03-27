using DataProcessor;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
PrintProcessedData();

void SetData(ref Data data)
{ 
    data.Source = "File";
    data.DataTypeProcess = "Binary";

}

void PrintProcessedData()
{
    Data data = new Data();
    SetData(ref data);
    DataProcessorManagingFactory dataProcessorManagingFactory = new DataProcessorManagingFactory();
    IDataProcessorFactory dataProcessorFactory = dataProcessorManagingFactory.GetDataProcessingFactory(data);
    DataProcessorManager processManager = new DataProcessorManager(dataProcessorFactory);
    var processedData = processManager.ProcessData();
    Console.WriteLine(processedData);
}




