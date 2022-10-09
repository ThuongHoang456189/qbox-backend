﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Payment.Web.Pages;

public class IndexModel : PaymentPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}