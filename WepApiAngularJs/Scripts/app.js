/// <reference path="angular-mocks.js" />

var app = angular.module("myApp", []); 

app.controller("ProductCtrl",
	function ($scope) {
		$scope.urunler = [];

		$scope.ekle = function() {
			$scope.urunler.push({
				urunAdi: $scope.yeniKisi.urunAdi,
				fiyat: $scope.yeni.fiyat,
				eklemeZamani: new Date()
			});
		};
	});