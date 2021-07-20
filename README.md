# SpecFlowProjectAllure
SpecFlow 4.7 .Net FW, NUnit, SpecFlow , Allure




Learning Ref: 


Concepts:
Monday – System and Environment setup. Looking at C# syntax and similarity with Java. Explore Udemy courses
Tuesday – Creating a basic framework using C#, .Net framework and SpecFlow
Wednesday – Case study and different components of a framework
Thursday – Implement Entity Framework and Allure reporting
Friday – RestSharp, DocFx and .Net Core


Allure Reporting: 


Step 1:
Invoke-Expression (New-Object System.Net.WebClient).DownloadString('https://get.scoop.sh')


Step 2:
Run the below one if we are getting any error

 
Set-ExecutionPolicy RemoteSigned -scope CurrentUser

Then it would ask to select “Yes or No” option: Give yes for that
Then close the power shell and reopen it and execute step 1

Step 3: 
scoop install allure

Step 4: 
allure --version

---------------------------------------------------
Reference for Report Generation via CLI: 

Project Folder: C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure
Allure Installation Path: C:\Users\****\scoop\apps\allure\2.14.0\bin
Create Folders for TRX: C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure\Allure\TRXFiles 
Create Folder for Reports: C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure\Allure\Reports



cd C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure

dotnet test "SpecFlowProjectAllure.csproj" --logger trx --results-directory "C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure\Allure\TRXFiles"

cd C:\Users\****\scoop\apps\allure\2.14.0\bin

allure generate "C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure\Allure\TRXFiles" -o "C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure\Allure\Reports" --clean

allure open C:\Users\****\source\repos\SpecFlowProjectAllure\SpecFlowProjectAllure\Allure\Reports


--------------------------------------------------------------------
Ref Links:
https://specflow.org/?gclid=EAIaIQobChMIgfOBiqvi8QIVydPtCh02HwEHEAAYASAAEgJuY_D_BwE
https://www.lambdatest.com/blog/setting-up-selenium-in-visual-studio/
https://testscriptdemo.com/   (Test App)
https://testifyqa.com/csharp-frameworks/
https://www.toolsqa.com/restsharp/validate-response-status-using-rest-sharp/
https://www.automatetheplanet.com/test-automation-reporting-allure/#tab-con-2
