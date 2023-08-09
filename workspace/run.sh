# a) Install dependencies
dotnet restore

# b) Off course, provide build the code first
dotnet build

# Run the main program
dotnet run --project ./Program.cs

# For running the test cases in parallel
dotnet test --filter FullyQualifiedName~HelloWorld.Tests.ProgramTests.Main_PrintsHelloWorld /p:ParallelizeTestCollections=True
