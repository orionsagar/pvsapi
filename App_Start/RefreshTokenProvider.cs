﻿using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PVSAPI.App_Start
{
    public class RefreshTokenProvider : IAuthenticationTokenProvider
    {
        private static ConcurrentDictionary<string, AuthenticationTicket> _refreshTokens = new ConcurrentDictionary<string, AuthenticationTicket>();
        public async Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            //var guid = Guid.NewGuid().ToString();

            //// copy all properties and set the desired lifetime of refresh token  
            //var refreshTokenProperties = new AuthenticationProperties(context.Ticket.Properties.Dictionary)
            //{
            //    IssuedUtc = context.Ticket.Properties.IssuedUtc,
            //    ExpiresUtc = DateTime.UtcNow.AddDays(35600)//DateTime.UtcNow.AddYears(1)  
            //};
            //var refreshTokenTicket = new AuthenticationTicket(context.Ticket.Identity, refreshTokenProperties);

            //_refreshTokens.TryAdd(guid, refreshTokenTicket);

            //// consider storing only the hash of the handle  
            //context.SetToken(guid);
        }

        public async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {
            //AuthenticationTicket ticket;
            //string header = context.OwinContext.Request.Headers["Authorization"];

            //if (_refreshTokens.TryRemove(context.Token, out ticket))
            //{
            //    context.SetTicket(ticket);
            //}
        }

        public void Create(AuthenticationTokenCreateContext context)
        {
            throw new NotImplementedException();
        }

        public void Receive(AuthenticationTokenReceiveContext context)
        {
            throw new NotImplementedException();
        }
    }
}