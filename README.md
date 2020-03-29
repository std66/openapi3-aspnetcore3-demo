# openapi3-aspnetcore3-demo
This repository demonstrates how to build microservice with OpenApi 3.0 and ASP.NET Core 3.1 using API-first approach. By following my commits step-by-step, you will be guided through the development process of a server and a client using this methodology.

What is API-first development?
------------------------------
1. Using OpenApi 3.0 specification, you design and document your API. So, you will have an OpenApi 3.0 JSON or YAML document. (I choose YAML)
2. You will use OpenApi Generator to generate a stub code for the server. You may need to customize the generated code to fit your needs.
3. You will use the generated code to implement your API.

What are the benefits of this approach?
---------------------------------------
1. Your clients and test engineers can start working early. Even before you start implementing the server.
2. You don't need to start from scratch. Thanks to the generated code, you have a baseline you can use.
3. Thanks to the designing process and to it's result (the OpenApi document), you may have clear requirements (if you do it right).

What is against this approach?
------------------------------
1. You have to manually write the OpenApi document. Therefore, there's possibility for mistake. However, there are validators you can use to check the correctness of the document.
2. The OpenApi document may change during development. You need to figure out a process to handle these scenarios effectively.

Resources
---------
- OpenApi online editor and validator: http://editor.swagger.io/
- OpenApi 3.0 specification: https://swagger.io/specification/
- OpenApi code generator: https://openapi-generator.tech/
