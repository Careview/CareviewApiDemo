# Careview Api Demo

## Getting Started

You will need a subscription key to use the Careview API. [Contact us](http://www.careviewapp.com/contact-us) to have one provisioned for you.

In Careview go to API Keys in settings [https://app.careview.io/Settings/ApiKeys](https://app.careview.io/Settings/ApiKeys). Here you can create an API key mapped to one of your organisation's user accounts. All API activity using the key will assume the identity of that user.

The API key is used in the header of the request (header key "ApiKey"). The subscription key is appended on each call in the URL with a parameter "subscription-key", eg clients/get/123456?subscription-key=(Your API Key Here)

## API Endpoint

Refer to the samples for the API endpoint. There are two:
1) Production
2) Sandbox (test), suffixed with /test


