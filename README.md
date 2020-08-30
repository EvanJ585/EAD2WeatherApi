# EAD2WeatherApi - Section of EAD2 Elapsed CA 2020
## Contains an ASP.Net Web Core (Web API) in C#
##### - It is a RESTful web service that provides weather information to an Android app on request. The service maintains up to date weather information for a range of cities in a SQL database.
##### - It has been deployed on Azure. The weather information is be stored in a SQL Azure database and retrieved by the service operation as required.
##### - The weather service provides one operation to allow the weather information for a specified city to be returned. The operation can be called by any client requiring weather information i.e. an Android app.

### Hosted and published on Azure. Using Azures SQL Database.
* https://ead2weatherapi.azurewebsites.net/swagger/index.html

##### Link to allow the weather information for a specified city to be returned 
* https://ead2weatherapi.azurewebsites.net/api/Weathers/city/Dublin

**App Service Plan :** EAD2WeatherApiServicePlan

**App Service:** EAD2WeatherApi

**SQL Server:** EAD2WeatherApiDB (ead2weatherapidbserver/EAD2WeatherApiDB)

**SQL Database:** ead2weatherapidbserver.database.windows.net

**Resource Group:** EAD2WeatherApiResourceGroup
