To run and test my HomeRentalAppliancesSystem, the following steps are necessary:
===================================================================================
1. You need to set up project download mysql server, workbench and mysql connect for .net. 

2.After download mysql server and workbench installs mysqldump file to your mysql server local database

 - I have included "rental_appliances.sql" SQL file.

 - Please import this "rental_appliances.sql" SQL file into the MySQL Workbench.

3.Add references "MySql.Data" extension to project file.
________________________________________________________________________________________

"How to import self-contained SQL file" into the MySQL Workbench

- Open the MySQL Workbench.
- In the "Server" tab, click on "Data Import".
- Select "Import from Self-Contained File" and locate folder and select "rental_appliances" SQL file.
- And then, click "New" of Default Target Schema: in order to create schema and type as "rental_appliances".
- Please go to "Import Progress" tab, and then click "Start Import".
- Then, please refresh SCEMAS under Navigator.
__________________________________________________________________________________________

****Important****

	After importing the "rental_appliances" SQL file, please change to your own MySQL database, uid and pwd in all necessary files of my program.


// Database connection string
private static readonly string connectionString = "server=localhost;uid=root;pwd=1234;database=rental_appliances";
 


_________________________________________________________________________________________


=======================Run Project from Visual studio=========================

The followings are testing data for my system.

Admin 
+++++

Username      -	admin
Password      -	Admin123


Users
+++++++

Username      -	User
Password      -	User1234567

Or

Users
+++++++

Username      -	User2
Password      -	User23456

Or

Users
+++++++

Username      -	User3
Password      -	User34567

	

___________________________________________________________________________________
