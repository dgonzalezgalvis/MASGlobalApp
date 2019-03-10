# MASGlobalApp

	
Right now the application is deployed in Azure, distributed as follows:

# https://masglobalwebangular.azurewebsites.net/
Angular 2/webpack web application

# http://masglobalapi20190309101256.azurewebsites.net/
.Net Web api 2.0 rest application, currently there are just two end points listening:
 - GET api/employees
 - GET api/employees/:id

For manual deployment, please follow these steps:

1. Download repo and open MASGlobalApp.sln in visual studio 2017.
2. Set MASGlobalApp as your default project.
3. Run the project: This should run the web api project.
4. Go to the Website/MASGlobalWeb folder; copy all content and past it in a web server. This should run the angular web app application consuming the web api in azure.
5. In case you want to make the web app to consume your local services, open the followin file: \Website\MASGlobalWeb\src\app\services\employees\employees.services.ts, in line 7, change the route from the azure url to your local web api service.
