angular.module('module-app',['module-A','module-B'])
        .controller('maincontroller',['$scope','$rootScope',function($scope,$rootScope)
        {
           $rootScope.company="Aurionpro";
           $scope.msg="Inside Main Controller"
           console.log("main controller created");
         }] );
         angular.module('module-A',[])
        .controller('ControllerA',['$scope','$rootScope',function($scope,$rootScope)
        {
            console.log($rootScope.company);
           $scope.msg="Inside A"
           console.log("A created");
         } ]);
         angular.module('module-B',[])
        .controller('ControllerB',['$scope','$rootScope',function($scope,$rootScope)
        {
            console.log($rootScope.company);
           $scope.msg="Inside B"
           console.log("B created");
         }] );

         var app=angular.module('event-app', [])
        app.controller('controller',['$scope', function ($scope) {
            $scope.myFunc = function () {
                $scope.students =[{ id: 1, name: 'priyank', cgpa: 5.0, image: 'BXS_0011.jpg' },{ id: 2, name: 'ratnesh', cgpa: 8.5, image: 'BXS_0011.jpg' },{ id: 3, name: 'meet', cgpa: 9.5, image: 'BXS_0011.jpg' }] 
            }
        }])
       


        