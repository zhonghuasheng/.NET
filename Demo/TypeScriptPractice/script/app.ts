{
    function sayHello()
    {
        const compiler = (document.getElementById('cmopiler') as HTMLInputElement).value;
        const framework = (document.getElementById('framework') as HTMLInputElement).value;
        return `Hello ${compiler} and ${framework}`;
    }
}
