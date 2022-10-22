<div id="top"></div>

[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<br />
<div align="center">
<h3 align="center">
    Ploomes Challenge
</h3>

  <p align="center">
    A Small ASPNet Core Mvc app that uses a hosted db to handle info.
    <br />
  </p>
</div>

### Built With

* C#
* .Net Core

## [Document](https://webapp-221022003223.azurewebsites.net/swagger/index.html)

<p>
    UniApp is a relational database that features 2 models with a one-to-many relationship.
    A Client is registered and can have many travel Bookings.

```
Client {
    clientId: integer($int32)
    name*: string
        [maxLength: 20]
        [minLength: 3]
    email*:	string
        [maxLength: 20]
        [minLength: 3]
    bookings: Booking
        [nullable]
}

Booking {
    bookingId: integer($int32)
    name*: string
    startLocation*: string
    endLocation*: string
    clientId: integer($int32)
    client: Client
}
```

The Routes documentation can be viewed [Here](https://webapp-221022003223.azurewebsites.net/swagger/index.html). (Powered By Swagger).
</p>

## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>

## Contact

Hefler - [@heflerdev](https://www.instagram.com/heflerdev/) - heflerdev@gmail.com

<p align="right">(<a href="#top">back to top</a>)</p>

[issues-shield]: https://img.shields.io/github/issues/heflerdev/uniapp.svg?style=for-the-badge

[issues-url]: https://github.com/HeflerDev/uniapp/issues

[license-shield]: https://img.shields.io/github/license/heflerdev/uniapp.svg?style=for-the-badge

[license-url]: https://github.com/heflerdev/uniapp/LICENSE.txt

[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-default.svg?style=for-the-badge&logo=linkedin&colorB=blue

[linkedin-url]: https://linkedin.com/in/heflerdev

[product-screenshot]: images/screenshot.png