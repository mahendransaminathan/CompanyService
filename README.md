# Build, publish and deploy - Back End Service
Create an Azure Subscription from portal.azure.com (if not created already)  
Follow the below steps to create Azure App Service for backend   
• Search for "App Services" and select "App Services" from Services section   
• Select Create menu option under App Services   
• Select Web App option from the drop down menu   
• Create Web App Page will be displayed   
• Select one of the subscription from available subscriptions   
• Create a new resource group by selecting "Create new" option   
• Provide a resource group name example "PLA" and click on Ok button   
• Enter Web App Name example CompanyService   
• Select code Radio button for Publish option   
• Select Runtime stack as .Net 9 (STS)   
• Select Operating System as Windows   
• Select near by region for Region example "East US 2"   
• Under Pricing Plans leave default value for Windows Plan   
• Select Free F1 for pricing plan   
• Select Disabled option for Zone Redundancy   
• Click on Review + create button    
• Click on Create button from "Review + create" tab

• Go to Azure Portal and select the PLAService app service  
• Go to Settings section from left side of the screen and select Configuration section  
• Under Default settings section, select "on" option for the following two fields  
• Under Platform settings, Select on option for SCM Basic Auth Publishing credentials  
• Select on option for FTP Basic Auth Publishing credentials  
• click on save button to save the changes  

• Click on Download publish profile option to download the publish profile from your Company Service App Service  
• Open the downloaded the publish profile and copy the content to notepad  

• Go to Settings under Back end Github repository  
• Scroll down to select Secrets and Variables under Security section on the left side of the screen  
• Select on Actions option and click on New Repository secret button.  
• Provide a name to this secret example Azure_Publish_Profile and paste the service principle from notepad  
• Click on Add Secret button  

# Create Cosmos DB by the following steps as given below

1. Go to Azure Portal - https://portal.azure.com/#home
2. Click on Search box and enter Cosmos
3. Select Azure Cosmos DB under Services
4. Click on Create option under Azure Cosmos DB
5. Click on Create button from Azure Cosmos DB for NoSQL section
6. Select one of the subscription from available subscriptions
7. Create a new resource group by selecting "Create new" option
8. Enter Account Name example CompanyService
9. Select "Disable" option for Availability Zones
10. Select a location as near to your location
11. Select "Provisioned throughput" option for Capacity Mode
12. Select "Apply" for Apply Free Tier Discount
13. Click on the "Limit the total amount of throughput that can be provisioned on this account" check box for Limit total account throughput
14. Click on Review + Create button
15. Review + Create section will be displayed
16. Click on the Create button
17. The Cosmos DB account will be created

1. Go to Azure Home Page
2. Select the search box and enter the Azure Cosmos DB
3. Select Azure Cosmos DB under services
4. Newly created Cosmos DB account will be displayed
5. Select the Cosmos DB account
6. Under Azure Cosmos DB account, Click on +Add Container option
7. New Container window will pop up at the right side of the screen
8. Under Database id, Select the Create new Radio button
9. Enter the new Database id in the textbox under Create new Radio button 
10. Enter the Container Id under Container id section
11. Enter the Partition Key under Partition Key section. This is your primary key from your Entity
12. Under Container throughput section, select the Autoscale
13. Under Container Max RU/s, Enter 1000
14. Under Unique Keys section, do not make any change
15. Under "Enable analytical store capability to perform near real-time analytics on your operational data, without impacting the performance of transactional workloads." section, do not make any change
16. Under "Azure Synapse Link is required for creating an analytical store container. Enable Synapse Link for this Cosmos DB account. " do not make any change.
17. Click on Ok button to create the Cosmos DB and Container

 # Creating Connection String in Azure Cosmos DB
 1. Go to the created Azure Cosmos DB account
 2. Select "Data Explorer" at the left hand side of the screen
 3. Connect option will be displayed. Click on the connect option
 4. Copy the URI and Primary Key to your notepad
 5. Go to your CompanyService App service
 6. Select Settings at the left hand side of the screen
 7. Select Configuration under settings
 8. Click on the "Click here to go to Environment Varialbes menu" link
 9. Click on +Add button under App settings
 10.  Add/Edit Application setting window will pop up
 11.  Under Name*, Type COSMOS_DB_KEY
 12.  Under Value, copy the Primary Key from your notepad and paste it
 13.  Click on Apply button at the bottom of the screen
 14.  Click on +Add button again
 15.  Add/Edit Application setting window will pop up again
 16.  Under Name*, type COSMOS_DB_ENDPOINT
 17.  Under Value, copy the URI from your notepad and paste it
 18.  Click on Apply button at the bottom of the screen

# Instructions to follow
1. Update front end URL in your Program.cs file in Back end service (Company Service)  
2. When you are testing in Postman - with your URL from Company Service App service include /api/company
3. Try connecting to SQL Server from SSMS. The SQL server may be in connecting mode, try multiple times connecting to SQL server from SSMS before connecting Postman or Front End.
4. The way to kill the port 3000 if its already used. Add the following command in Package.json in the Front End Application code
5. "start": "cmd /c \"for /f \"tokens=5\" %a in ('netstat -ano ^| findstr :3000') do taskkill /PID %a /F && react-scripts start || react-scripts start\""


