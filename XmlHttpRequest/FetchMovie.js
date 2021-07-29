// var client = new HttpClient();
// var request = new HttpRequestMessage
// {
//     Method = HttpMethod.Get,
//     RequestUri = new Uri("https://movies-tvshows-data-imdb.p.rapidapi.com/?type=get-movies-by-title&title=matrix"),
//     Headers =
//     {
//         { "x-rapidapi-key", "410015d089mshb4f7e108a235c08p1cbd83jsn49f398ba83b5" },
//         { "x-rapidapi-host", "movies-tvshows-data-imdb.p.rapidapi.com" },
//     },
// };
// using (var response = await client.SendAsync(request))
// {
//     response.EnsureSuccessStatusCode();
//     var body = await response.Content.ReadAsStringAsync();
//     Console.WriteLine(body);
// }
// **********************
// fetch("https://movies-tvshows-data-imdb.p.rapidapi.com/?type=get-movies-by-title&title=matrix",
// {
//     Method : 'GET',
//     Headers:
//     {
//         "x-rapidapi-key": "410015d089mshb4f7e108a235c08p1cbd83jsn49f398ba83b5",
//         "x-rapidapi-host": "movies-tvshows-data-imdb.p.rapidapi.com"
//     }
// })
// .then(r => r.json())
// .then(d => console.log(d));
// **************************
// var request = new HttpRequestMessage();
// request.open('GET', 'https://movies-tvshows-data-imdb.p.rapidapi.com/?type=get-movies-by-title&title=matrix', true);
// request.open();var client = new HttpClient();
var request = new HttpRequestMessage()
request.open('GET', 'https://movies-tvshows-data-imdb.p.rapidapi.com/?type=get-movies-by-title&title=matrix', true);

    Headers =
    {
        { "x-rapidapi-key", "410015d089mshb4f7e108a235c08p1cbd83jsn49f398ba83b5" },
        { "x-rapidapi-host", "movies-tvshows-data-imdb.p.rapidapi.com" },
    },

using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}