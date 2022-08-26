# WebApiDemo
Now we will see how request and response work for different HTTP methods. Let’s assume we have an API(https://www.yourdomain.org/api/students) for all students data of a school.

GET: Request for all Students.
Request
GET:/api/students

POST: Request for Posting/Creating/Inserting Data
Request

POST:/api/students

{“name”:”Raj”}

PUT or PATCH: Request for Updating Data at id=1
Request

PUT or PATCH:/api/students/1

{“name”:”Raj”}

DELETE: Request for Deleting Data of id=1
Request
DELETE:/api/students/1
