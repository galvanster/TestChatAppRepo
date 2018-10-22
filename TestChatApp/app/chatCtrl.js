angular.module('app').controller('chatCtrl', function ($scope, chat) {
    $scope.messages = [];

    $scope.nameSet = false;

    $scope.setName = function () {
        $scope.nameSet = true;
    }

    $scope.sendMessage = function () {
        chat.server.sendMessage({ name: $scope.name, message: $scope.newMessage });
        $scope.newMessage = "";
    };

    chat.client.newMessage = function onNewMessage(message) {
        $scope.messages.push({ message: message });
        $scope.$apply();
        console.log(message);
    };
});