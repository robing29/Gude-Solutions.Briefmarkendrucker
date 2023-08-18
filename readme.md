<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a id="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
-->



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="">
    <img src="readme-images/Gude-Solutions-250x180.png" alt="Logo" width="250" height="180">
  </a>

<h3 align="center">Gude Solutions Briefmarkendrucker</h3>

  <p align="center">
    Kleines WinForms Programm, welches .PDFs mit Briefmarken von der Deutschen Post automatisch auf 10x15cm Labels druckt.
    <br />
    <br />
    <br />
    <a href="https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/issues">Report Bug</a>
    ·
    <a href="https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Inhaltsverzeichnis</summary>
  <ol>
    <li><a href="#uber-das-projekt">Über das Projekt</a></li>
    <li><a href="#built-with">Built With</a></li>
    <li><a href="#voraussetzungen">Voraussetzungen</a></li>
    <li><a href="#installation">Installation</a></li>
    <li><a href="#benutzung">Benutzung</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Über das Projekt

![Product Name Screen Shot][product-screenshot]

Dieses .NET 7 WinForms Programm nimmt als Input PDFs der Deutschen Post entgegen. Diese PDFs enthalten Briefmarken, die auf 10x15cm Labels gedruckt werden sollen. Das Programm erkennt die Labels automatisch und druckt diese auf dem gewünschten Drucker im 10x15cm Format aus. Dadurch entfällt ein händisches auswählen der Briefmarken.
<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Built With
* [![c#]][c#-url]
* [![dotnet]][dotnet-url]
* [![spirepdf]][spirepdf-url]
<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Voraussetzungen

- Windows 10/11

## Installation

1. Download des letzten Releases
2. Mitgelieferten Installer benutzen

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Benutzung

Die Deutsche Post liefert zwar einige Möglichkeiten für den Briefmarkendruck, allerdings sind diese an spezifische Druckeranbieter gekoppelt. Mithilfe eines günstigen No-Name Druckers lässt sich ordentlich Geld sparen, allerdings besteht dann das Problem, dass man die Briefmarken nicht automatisch auf die Labels drucken kann.

Dieses Programm löst dieses Problem, indem es die Briefmarken automatisch erkennt und auf dem gewünschten Drucker im 10x15 Format ausdruckt.

Aktuell ist das Druckformat (10x15cm) fest einprogrammiert, da mein Kunde nur diesen Anwendungsfall hat. Andere Formate sind auf Anfrage ggf. möglich.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->
## Contact
- [![LinkedIn][linkedin-shield]][linkedin-url]
- [Contact me via E-Mail](robin.gude@gude-solutions.de)

Project Link: [https://github.com/robing29/Gude-Solutions.Briefmarkendrucker](https://github.com/robing29/Gude-Solutions.Briefmarkendrucker)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/robing29/Gude-Solutions.Briefmarkendrucker.svg?style=for-the-badge
[contributors-url]: https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/robing29/Gude-Solutions.Briefmarkendrucker.svg?style=for-the-badge
[forks-url]: https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/network/members
[stars-shield]: https://img.shields.io/github/stars/robing29/Gude-Solutions.Briefmarkendrucker.svg?style=for-the-badge
[stars-url]: https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/stargazers
[issues-shield]: https://img.shields.io/github/issues/robing29/Gude-Solutions.Briefmarkendrucker.svg?style=for-the-badge
[issues-url]: https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/issues
[license-shield]: https://img.shields.io/github/license/robing29/Gude-Solutions.Briefmarkendrucker.svg?style=for-the-badge
[license-url]: https://github.com/robing29/Gude-Solutions.Briefmarkendrucker/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/robin-gude
[product-screenshot]: readme-images/briefmarkendrucker-promo.png
[product-screenshot2]: readme-images/briefmarkendrucker-beispiel-blacked.png
[dotnet]:https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[dotnet-url]: https://github.com/dotnet
[c#]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white
[c#-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[spirepdf]: https://img.shields.io/badge/FreeSpire.Pdf-8.6.0-blue
[spirepdf-url]: https://www.e-iceblue.com/Introduce/free-pdf-component.html