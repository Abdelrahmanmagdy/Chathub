var ChatApp = angular.module('ChatApp', []);
ChatApp.controller('ChatController', function ($scope, ChatService) {

    getChats();
    function getChats() {
        ChatService.getChats()
            .success(function (Chats) {
                $scope.Chats = Chats;
                console.log($scope.Chats);
            })
            .error(function (error) {
                $scope.status = 'Unable to load Chat data: ' + error.message;
                console.log($scope.status);
            });
    }
});

ChatApp.factory('ChatService', ['$http', function ($http) {

    var ChatService = {};
    ChatService.getChats = function () {
        return $http.get('/Home/GetChatMasters');
    };
    return ChatService;

}]);