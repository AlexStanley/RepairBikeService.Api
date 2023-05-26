# bike-repair-app (frontend) and RepairBikeService.Api (backend)

1. Open bike-repair-app (frontend project) in PowerShell .../RepairBikeService.Api/bike-repair-app and start it using 

ng serve

2. Open RepairBikeService.Api (backend project) in Visual Studio 2022 (IDE) and start the project.

3. Change DefaultConnection String from Server=DESKTOP-681ABIL to Server=<your server name> into appsettings.json file

4. Apply migrations using Package Manager Console

update-database

5. Open page http://localhost:4200/ and there will be the form.

6. Fill in all the filds and push "Submit" button.
If you don't fill in all fields, you won't be able to submit data (push the button).