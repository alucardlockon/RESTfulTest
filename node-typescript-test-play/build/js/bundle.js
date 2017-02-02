/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};

/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {

/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;

/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};

/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);

/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;

/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}


/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;

/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;

/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";

/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ function(module, exports) {

	eval("var User = (function () {\r\n    function User() {\r\n    }\r\n    User.prototype.setName = function (_name) {\r\n        this.name = _name;\r\n    };\r\n    return User;\r\n}());\r\nfunction getA() {\r\n    var a = 'c';\r\n    console.log(a);\r\n}\r\nfunction crateUser() {\r\n    var user = new User();\r\n    user.setName('Atom');\r\n    console.log(user.name);\r\n}\r\ncrateUser();\r\n\n\n//////////////////\n// WEBPACK FOOTER\n// ./src/ts/go.js\n// module id = 0\n// module chunks = 0\n//# sourceURL=webpack:///./src/ts/go.js?");

/***/ }
/******/ ]);