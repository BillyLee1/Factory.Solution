# _Factory.Solution_

#### By _**Billy Lee**_

#### _A simple web app to create and edit machines and engineers._

## Technologies Used

* _C#_
* _.NET6_
* _HTML_
* _CSS_
* _MySQLWorkbench_
* _SQL Database_
* _AspNetCore.Mvc_
* _AspNetCore_
* _EntityFrameworkCore_
* _Linq_
* _AspNetCore.Mvc.Rendering_

## Description

_A simple web application to create and edit machines and engineers. Allows user to make relationships between machines and their engineers. You may remove and add machines and engineers. Used to keep track of which engineers are licensed to work on each machine_

## Setup/Installation Requirements
* _Follow the steps below_

#### Installing .NET & MySQL
* _First, install .NET 6_
* _If it is not installed, please install .NET 6 with this link (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)_
* _Open the file_
* _Follow the installation intructions_
* _To confirm the the installation, on your command line in your terminal type "dotnet --version"_
* _install MySQL. Follow the instructions in here(https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)._

#### Configuring appsettings.json
* _Clone the repository_
* _Navigate to the 'Factory.Solution' directory on your computer_
* _Open it in VSCode or any text editor of your choosing_
* _ Go to the "Factory" Directory_
* _Create a new file called "appsettings.json_
* _In the appsettings.json file you will add the following code below_
* _*{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[NAME-YOU-WANT-FOR-YOUR-DATABASE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}*_


#### To add a migration and development server:_
* _Navigate to 'Factory.Solution' in your command line_
* _From there navigate to 'Factory'_
* _Run the command "dotnet build"_
* _Run the command "dotnet tool install --global dotnet-ef --version 6.0.0"_
* _Run the command "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0"_
* _Run the command "dotnet ef migrations add Initial"_
* _Run "dotnet ef database update" in your command line._
* _Then run the command "dotnet watch run"_

## Known Bugs

* _No bugs currently._


## License

_Please let me know if you see any bugs within this project. You can contact me through Discord or email me at codingbillylee@gmail.com_

[Copyright](https://opensource.org/licenses/MIT) (c) _2023_ _Billy Lee_
