(function () {
    angular.module('FBApp').factory('qbService', QBService);

    QBService.$inject = ['$http'];

    function QBService($http) {
        return {
            scrapeQBData: _scrapeQBData,
            getQBs: _getQBs
        };

        function _scrapeQBData() {
            return $http.get('/scrape/qb')
            .then(getQBDataCompleted)
            .catch(getQBDataFailed)

            function getQBDataCompleted(response) {
                return response;
            }
            function getQBDataFailed(error) {
                console.log('failed to get data', error)
            }
        }

        function _getQBs() {
            return http.get('/api/qb')
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