(function () {
    angular.module('FBApp').factory('scrapeService', ScrapeService);

    ScrapeService.$inject = ['$http'];

    function ScrapeService($http) {
        return {
            scrapeQBData: _scrapeQBData,
            scrapeRBData: _scrapeRBData
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

        function _scrapeRBData() {
            return $http.get('/scrape/rb')
            .then(getRBDataCompleted)
            .catch(getRBDataFailed)

            function getRBDataCompleted(response) {
                return response;
            }
            function getRBDataFailed(error) {
                console.log('failed to get data', error)
            }
        }
    }

})();