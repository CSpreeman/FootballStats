(function () {
    angular.module('FBApp').factory('qbService', QBService);

    QBService.$inject = ['$http'];

    function QBService($http) {
        return {
            getQBs: _getQBs
        };
        
        function _getQBs() {
            return $http.get('/api/qb')
            .then(getQBsComplete)
            .catch(getQBsFailed)

            function getQBsComplete(response) {
                return response;
            }
            function getQBsFailed(error) {
                console.log('failed to get data', error)
            }
        }

    }

})();