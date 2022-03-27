# DataProcessor
1. Repository to process the data in desired data type from desired source
2. DataProcessor is a console application which is implemented using Absract Factory Design Pattern with relation between source and datatype objects
3. Initially this is implemented with source as File and processing datatypes as Binary, Text and Text Reverse. And to support other sources and datatypes this can be extended.
4. At high level, we will compose Data class object with required source and Data type processing in Program.cs and this data will be passed to client class which process the data(reads data to specific datatype from provided path of specific source) based on input data object and prints it in console.  
5. This is developed using IDE tools Visual Studio 2022 with target .NET6.
6. Mainly it comprises of folders
 1. AbstractClasses :  This consists of Interfaces of Source and DataTypeProcess
 2. Abstract Factory : This folder consists of Interface IDataProcessorFactory which combines both Source Interface and DataTypeProcess Interace together at one place.
 3. Client : This folder consists of class which is responsible for actual processing the data which depends on interface dataprocessor factory.
 4. Concrete Classes : This folder consists of Classes which are dervied from ISource Interface and IDataTypeProcess interface.
 5. Concrete Factory : This folder consists of concrete factory classes which are derived from IDataProcessor Factory and returns concrete isntaces of both source and datatypeprocess.
 6. Enumerations :  This folder consists of types of source and data type processing supported in application
 7. Model :  This folder consists of class Data and it's properties
  
