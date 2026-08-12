using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Builder;
var builder=WebApplication.CreateBuilder(args);
var app=builder.Build();

app.MapGet("/",()=>{return "Welcome to BookApi";});
app.MapGet("book",()=>{
    string title= "Philosophers stone";
    int no_of_yr=28;

    return new
    {
        Title=title,
        No_of_yr=no_of_yr
    };
    });
    app.MapGet("/feedback",()=>{
    int stars=5;
    string feedback;
        if (stars == 5)
        {
            feedback="great";
        }
        else
        {
            feedback="average";
        }
        return feedback;

    });
    string Getfeedback(int stars)
{
    if (stars == 5 )
        return "Magnum Opus";

    if (stars == 4)
        return "Okayish";

    if (stars <= 3)
        return "Below Average";
    return "invalid";
}
app.MapGet("/review",()=>{
  
return Getfeedback(5);
    });
    app.MapGet("/books", () =>
{
    Book book = new Book
    {
        Title = "OliverTwist",
        Author = "N/A",
        Ratings = 4
    };

    return book;
});

app.Run();
