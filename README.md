# contact-form-backend-part
this a simple contact api , name, email, message , must integration with thoses repos (contact-form-front-end-part and contact-form-admin-part)

## install packages
```bash
dotnet add package microsoft.entityframeworkcore
```
## run
```bash
dotnet run 
```

## migration
```bash
dotnet ef migrations add InitialCreate
```
## Update Database
```bash
dotnet ef database update
```
## deploy project to (host ->public_html forlder)
first build the project with this commad
```bash
dotnet publish -c Release -o ./publish 
```
that will create publish folder, all you have to do is upload (publish folder contect)  -->  public_html folder , extract it there
