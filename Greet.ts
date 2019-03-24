class Student
{
     fullName:string;
    constructor(public firstName, public middleName, public lastName)
    {
        this.fullName = firstName + " " + middleName + " " + lastName;
    }
}

interface Person
{
    firstName: string;
    lastName: string;
}

function greeter(person: Student)
{
    return "Hello, " + person.firstName + " " + person.lastName;
}

let student = new Student("xia", "li", "zhang");

document.body.innerHTML=greeter(student);