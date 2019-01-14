var app = angular.module("myapp", []);
app.controller("TestCtrl", ['$scope', '$http',function ($scope, $http) {
    $scope.Message = "123";


    $http.get("/api/Values").then(function (response) {
        $scope.x = response.data;
    })

    //$http.get("api/TestController/Test123").success(function (data) {
    //    $scope.xx = data;
    //})


}]);