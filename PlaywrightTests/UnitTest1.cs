using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTest : PageTest
{
    [Test]
    public async Task HasTitle()
    {

        await Page.GotoAsync("http://localhost:5131/");
        await Expect(Page.GetByRole(AriaRole.Link, new() { Name = "Persons" })).ToBeVisibleAsync();
    }

}