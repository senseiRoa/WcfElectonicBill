# Welcome to WcfElectonicBill 👋
![Version](https://img.shields.io/badge/version-1.0.0-blue.svg?cacheSeconds=2592000)
[![Documentation](https://img.shields.io/badge/documentation-yes-brightgreen.svg)](https://github.com/senseiRoa/WcfElectonicBill#readme)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://github.com/senseiRoa/WcfElectonicBill/graphs/commit-activity)
[![License: ISC](https://img.shields.io/github/license/senseiRoa/nodeCrudExample)](https://github.com/senseiRoa/WcfElectonicBill/blob/master/LICENSE)

>Servicio Web que permite la recepción de Facturas Electrónicas y realiza diferentes operaciones de validación y cálculos sobre los valores ingresados:

## Requerimientos:
   
1. Crear un método que recibe una lista de facturas, cada factura  contiene los siguientes datos:
    
    * Id único de la factura.
    * NIT.
    * Descripción.
    * Valor Total.
    * Porcentaje IVA.

1. Para cada factura se debe validar lo siguiente:
    
    * El Id es un valor entero positivo.
    * El NIT debe contener sólo valores numéricos.
    * El valor total debe ser positivo.
    * No pueden existir 2 facturas con el mismo Id.
    * El valor del Iva es un valor entre 0(%) y 100(%)

1. En caso de presentarse algún error en las validaciones, se debe generar una    excepción con la descripción correspondiente.

1. En caso que todas las facturas pasen las validaciones correctamente se debe   retornar la suma de los valores totales de las facturas.

1. Crear un método que reciba como parámetro una factura y valide que los campos sean correctos. 

1. Crear un método que reciba como parámetro una factura y calcule el valor del IVA con base en el total, 

## 🏠 [Homepage](https://github.com/senseiRoa/WcfElectonicBill/blob/main/README.md)

### Solución

Se crea una aplicación WCF .NetFramework v4.8, cuenta con un Web Service denominado ´ElectronicBillService´

El servicio web debe Tiene Los siguientes Métodos:

1. AddElectronicBills: Este método recibe como parámetro una lista de facturas electrónicas 
   y retorna un objeto de tipo ´WSResponse´ con la sumatoria de los valores totales o con la lista de errores si los hay.

1. ValidateElectronicBill: Este método recibe como parámetro una  factura electrónica
   y retorna un objeto de tipo ´WSResponse´ con la respuesta verdadero o falso de la validación de la factura.

1. CalculateIVA: Este método recibe como parámetro como parámetro una  factura electrónica
   y retorna un objeto de tipo ´WSResponse´ con el valor del Iva calculado a partir del valor total.

## Author

👤 **Fabio Andres Roa Garcia**

* Website: https://www.linkedin.com/in/andres-roa-garcia-74324160/
* Github: [@senseiRoa](https://github.com/senseiRoa)
* LinkedIn: [@https:\/\/www.linkedin.com\/in\/andres-roa-garcia-74324160\/](https://linkedin.com/in/https:\/\/www.linkedin.com\/in\/andres-roa-garcia-74324160\/)

## 🤝 Contributing

Contributions, issues and feature requests are welcome!

Feel free to check [issues page](https://github.com/senseiRoa/WcfElectonicBill/issues). You can also take a look at the [contributing guide](https://github.com/senseiRoa/WcfElectonicBill/blob/master/CONTRIBUTING.md).

## Show your support

Give a ⭐️ if this project helped you!

## 📝 License

Copyright &copy; 2020 [Fabio Andres Roa Garcia](https://github.com/senseiRoa).

This project is [ISC](https://github.com/senseiRoa/WcfElectonicBill/blob/master/LICENSE) licensed.

***
_This README was generated with ❤️ by [readme-md-generator](https://github.com/kefranabg/readme-md-generator)_
