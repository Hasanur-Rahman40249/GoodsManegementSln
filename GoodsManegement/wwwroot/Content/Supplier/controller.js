app.controller('myController', function ($scope, myService) {
    SupplierList();


    $scope.newSupplier = {};
    $scope.clickedSupplier = {};
    $scope.message = "";

    function SupplierList() {
        myService.supplierList().then(function (result) {
            $scope.Suppliers = result.data;
            console.log(result.data);
        });
    };

    $scope.addSupplier = function () {
        myService.addSupplier($scope.newSupplier)
            .then(function (result) {
                $scope.newSupplier = {};
                $scope.message = "Data saved successfully";
                SupplierList()
                
            });
     
   };

    $scope.selectedSupplier = function (supplier) {
        $scope.clickedSupplier = supplier;
    };

    $scope.updateSupplier = function () {


        myService.updateSupplier($scope.clickedSupplier).then(function (result) {
            $scope.message = "Data Update successfully";
            $scope.Suppliers = result;
            SupplierList();
        }, function (result) {
            alert(result);
        });

    };

    $scope.deleteSupplier = function () {
        myService.deleteSupplier($scope.clickedSupplier.SupplierId).then(function (result) {
            $scope.message = "Data Delete successfully";
            SupplierList();
        }, function (result) {
            alert(result);
        });

    };

    $scope.clearInfo = function () {
        $scope.message = "";
    };

});
