angular.module('event-app', [])
.controller('controller',['$scope', function ($scope) {
    $scope.myFunc = function () {
        $scope.students =[{ id: 1, name: 'priyank', cgpa: 8.0, image: 'BXS_0011.jpg' },{ id: 2, name: 'ratnesh', cgpa: 7.0, image: 'BXS_0011.jpg' }] 
    }
}])