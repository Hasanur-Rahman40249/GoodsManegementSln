app.service('myService', function ($http) {

    this.supplierList = function () {
        var response = $http.get('Supplier/SupplierList');
        return response;
    };

    this.addSupplier = function (supplier) {
        //alert(supplier);
        var response = $http({
            method: 'post',
            url: 'Supplier/AddSupplier',
            data: JSON.stringify(supplier)
        });
        return response;
    };

    this.updateSupplier = function (supplier) {
        //alert(supplier);
        var response = $http({
            method: 'post',
            url: 'Supplier/UpdateSupplier',
            data: JSON.stringify(supplier),
        });
        return response;
    };

    this.deleteSupplier = function (SupplierId) {
        var response = $http({
            method: 'post',
            url: 'Supplier/DeleteSupplier',
            params: { SupplierId: JSON.stringify(SupplierId) }
        });
        return response;
    };

});
