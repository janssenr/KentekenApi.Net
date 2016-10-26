# KentekenApi.Net
=================

[![Build Status](https://travis-ci.org/janssenr/KentekenApi.Net.svg?branch=master)](https://travis-ci.org/janssenr/KentekenApi.Net)

KentenApi.Net is a ASP.Net client library for the overheid.io api web service.

**Links:**

* [More information](https://overheid.io/)
* [API documentation](https://overheid.io/documentatie/voertuiggegevens)

Requirements
------------

KentekenApi.Net works with ASP.Net 4.5.1 or up.

Installation
------------

KentekenApi.Net can easily be installed using the NuGet package

	Install-Package KentekenApi

Usage
-----

Instantiate the client and replace the API key with your personal credentials:

```
var apiKey = "replace_with_your_own_api_key";
var client = new KentekenApiClient(apiKey);

var result = client.GetKenteken("4-TFL-24");
```