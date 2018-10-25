# Code First Migrations with EF

#### Demo [here](http://efcodefirstsample-env.jixakememd.us-east-2.elasticbeanstalk.com/)


This is a super basic example. Did not do much coding here as it was mostly configurations and scafolding. 

# Architecture
This VS soultion consists of two projects:

### EFCodeFirstSample.Data
This is basically a DAL project, responsible for migrations.

Useful commands 
```bash
Add-Migration -ProjectName EFCodeFirstSample.Data <MigrationDescription>
Update-Database -ProjectName EFCodeFirstSample.Data
```

### EFCodeFirstSample
This is standard MVC 5 project responsible displaying basic CRUD operations 



