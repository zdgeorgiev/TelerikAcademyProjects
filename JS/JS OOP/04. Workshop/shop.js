"use strict";

function solve() {

    function getProduct(productType, name, price) {
        return {
            productType: productType,
            name: name,
            price: price
        }
    }

    function getShoppingCart() {

        let products = [];

        function add(product) {
            products.push(product);
            return this;
        }

        function remove(product) {
            const index = products.findIndex(p => p.name === product.name && p.productType === product.productType && p.price === product.price);

            if (index < 0) {
                throw 'Product not found';
            }

            products.splice(index, 1);

            return this;
        }

        function showCost() {
            return products.reduce((cost, product) => (cost + product.price) || 0, 0);
        }

        function showProductTypes() {

            let types = [];

            products.forEach(p => {
                if (types.indexOf(p.productType) === -1) {
                    types.push(p.productType);
                }
            });

            return types.sort();
        }

        function getInfo() {
            let p = {},
                totalPrice = 0;

            products.forEach(pr => {
                if (!p.hasOwnProperty(pr.name)) {
                    p[pr.name] = {
                        name: pr.name,
                        totalPrice: pr.price,
                        quantity: 1
                    }
                } else {
                    p[pr.name].totalPrice += pr.price;
                    p[pr.name].quantity++;
                }

                totalPrice += pr.price;
            });

            const groups = Object.keys(p)
                .sort()
                .map(n => {
                    return {
                        name: n,
                        quantity: p[n].quantity,
                        totalPrice: p[n].totalPrice
                    };
                });

            return {
                products: groups,
                totalPrice: totalPrice
            }
        }

        return {
            products: products,
            add: add,
            remove: remove,
            showCost: showCost,
            showProductTypes: showProductTypes,
            getInfo: getInfo,
        }
    }

    return {
        getProduct: getProduct,
        getShoppingCart: getShoppingCart
    };
}

module.exports = solve();