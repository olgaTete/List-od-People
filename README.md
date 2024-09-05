Task:
MVC Data, View Models ASP.NET Fundamentals
 Create a MVC project with a controller with views to displays/manage a list of people. 
The controller shall use a class that implements IPeopleService interface to take care of the business logic and use ViewModels to send/receive data for view(s) when needed. 
The PeopleService class shall use a class that implements IPeopleRepo interface to store the people’s data. 
Required Features: 
• An Index view that has the following:
 o Html table for the people.
 ▪ Each row should show:
 • a person’s name and the name of the city they live in,
 • a link that when clicked, takes you to a details page of that person.
 o A form that allows you search the people in the table for whose names or cities 
with name containing the string you entered in the form (PeopleService.Search).
 • A Create view that contains a form with the inputs needed to create a Person.
 • A Details view that shows all information about a single person.
 o A link that when clicked, deletes that person.

 ![image](https://github.com/user-attachments/assets/fa99b256-d370-423e-91bb-e08238c165c7)

![image](https://github.com/user-attachments/assets/fb9ca007-6665-4f8c-b51b-870a1b11b425)

![image](https://github.com/user-attachments/assets/d2702a22-369e-4287-ae78-d5a06de4d435)
