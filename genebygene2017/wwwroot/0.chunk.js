webpackJsonp([0,5],{

/***/ 551:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(0);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common__ = __webpack_require__(63);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__samples_routing_module__ = __webpack_require__(557);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__components_samples_component__ = __webpack_require__(554);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__samples_service__ = __webpack_require__(552);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__users_service__ = __webpack_require__(555);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__angular_forms__ = __webpack_require__(343);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__components_add_edit_sample_add_edit_sample_component__ = __webpack_require__(553);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SamplesModule", function() { return SamplesModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};








let SamplesModule = class SamplesModule {
};
SamplesModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["b" /* NgModule */])({
        imports: [
            __WEBPACK_IMPORTED_MODULE_1__angular_common__["a" /* CommonModule */],
            __WEBPACK_IMPORTED_MODULE_2__samples_routing_module__["a" /* SamplesRoutingModule */],
            __WEBPACK_IMPORTED_MODULE_6__angular_forms__["a" /* FormsModule */]
        ],
        declarations: [__WEBPACK_IMPORTED_MODULE_3__components_samples_component__["a" /* SamplesComponent */], __WEBPACK_IMPORTED_MODULE_7__components_add_edit_sample_add_edit_sample_component__["a" /* AddEditSampleComponent */]],
        providers: [
            __WEBPACK_IMPORTED_MODULE_4__samples_service__["a" /* SamplesService */],
            __WEBPACK_IMPORTED_MODULE_5__users_service__["a" /* UsersService */]
        ]
    })
], SamplesModule);

//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/samples.module.js.map

/***/ }),

/***/ 552:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(0);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__shared_util_repo_service__ = __webpack_require__(342);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return SamplesService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};


let SamplesService = class SamplesService {
    constructor(repo) {
        this.repo = repo;
        this.SamplesUrl = 'api/Samples/'; // URL to web api
    }
    getAll() {
        return __awaiter(this, void 0, void 0, function* () {
            return this.repo.get(this.SamplesUrl + 'GetAllSamplesWithName');
        });
    }
    getSamplesByName(name) {
        return __awaiter(this, void 0, void 0, function* () {
            return this.repo.get(this.SamplesUrl + 'user/' + name);
        });
    }
    getSamplesbyStatus(statusId) {
        return __awaiter(this, void 0, void 0, function* () {
            return this.repo.get(this.SamplesUrl + 'status/' + statusId);
        });
    }
    create(sample) {
        return __awaiter(this, void 0, void 0, function* () {
            return this.repo.post(this.SamplesUrl, sample);
        });
    }
};
SamplesService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__shared_util_repo_service__["a" /* RepoService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__shared_util_repo_service__["a" /* RepoService */]) === "function" && _a || Object])
], SamplesService);

var _a;
//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/samples.service.js.map

/***/ }),

/***/ 553:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(0);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__(341);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__samples_service__ = __webpack_require__(552);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__users_service__ = __webpack_require__(555);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__models_samples__ = __webpack_require__(556);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AddEditSampleComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};





let AddEditSampleComponent = class AddEditSampleComponent {
    constructor(samplesService, usersService, router) {
        this.samplesService = samplesService;
        this.usersService = usersService;
        this.router = router;
        this.sample = new __WEBPACK_IMPORTED_MODULE_4__models_samples__["a" /* Samples */]();
        this.message = "Enter New Sample To See Message";
        this.isSucceed = false;
        this.isNewSample = true;
        this.users = [];
    }
    ngOnInit() {
        this.sample.createdAt = new Date();
        this.sample.barcode = '12344';
        this.sample.firstName = 'John';
        this.sample.lastName = 'Doe';
        this.sample.sampleId = -1;
        this.sample.createdBy = 5;
        this.usersService.getAll()
            .then(r => {
            this.users = r;
            console.log(r);
        });
    }
    save() {
        console.log(this.sample);
        this.samplesService.create(this.sample)
            .then(r => {
            console.log(r);
            this.isNewSample = false;
            if (r.ok) {
                this.isSucceed = true;
            }
            else {
                this.isSucceed = false;
            }
            this.message = r.toString() + '  "message from Server": ' + r.text();
        });
    }
};
AddEditSampleComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Q" /* Component */])({
        selector: 'app-add-edit-sample',
        template: __webpack_require__(560),
        styles: [__webpack_require__(558)]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_2__samples_service__["a" /* SamplesService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__samples_service__["a" /* SamplesService */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_3__users_service__["a" /* UsersService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_3__users_service__["a" /* UsersService */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* Router */]) === "function" && _c || Object])
], AddEditSampleComponent);

var _a, _b, _c;
//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/add-edit-sample.component.js.map

/***/ }),

/***/ 554:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(0);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__(341);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__samples_service__ = __webpack_require__(552);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return SamplesComponent; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



let SamplesComponent = class SamplesComponent {
    constructor(samplesService, router) {
        this.samplesService = samplesService;
        this.router = router;
        this.samples = [];
    }
    getSamples() {
        this.samplesService.getAll()
            .then(r => {
            this.samples = r;
            console.log(r);
        });
    }
    getSamplesbyName() {
        this.samplesService.getSamplesByName(this.nameSearch)
            .then(r => {
            this.samples = r;
            console.log(r);
        });
    }
    getSamplesbyStatus() {
        this.samplesService.getSamplesbyStatus(this.statusId)
            .then(r => {
            this.samples = r;
            console.log(r);
        });
    }
    ngOnInit() {
        this.getSamples();
    }
};
SamplesComponent = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Q" /* Component */])({
        selector: 'app-samples',
        template: __webpack_require__(561),
        styles: [__webpack_require__(559)]
    }),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_2__samples_service__["a" /* SamplesService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_2__samples_service__["a" /* SamplesService */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* Router */]) === "function" && _b || Object])
], SamplesComponent);

var _a, _b;
//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/samples.component.js.map

/***/ }),

/***/ 555:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(0);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__shared_util_repo_service__ = __webpack_require__(342);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return UsersService; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};


let UsersService = class UsersService {
    constructor(repo) {
        this.repo = repo;
        this.UsersUrl = 'api/Users/'; // URL to web api
    }
    getAll() {
        return __awaiter(this, void 0, void 0, function* () {
            return this.repo.get(this.UsersUrl);
        });
    }
    create(user) {
        return __awaiter(this, void 0, void 0, function* () {
            return this.repo.post(this.UsersUrl, user);
        });
    }
};
UsersService = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["c" /* Injectable */])(),
    __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__shared_util_repo_service__["a" /* RepoService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__shared_util_repo_service__["a" /* RepoService */]) === "function" && _a || Object])
], UsersService);

var _a;
//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/users.service.js.map

/***/ }),

/***/ 556:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
class Samples {
}
/* harmony export (immutable) */ __webpack_exports__["a"] = Samples;

//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/samples.js.map

/***/ }),

/***/ 557:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__(0);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__(341);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__components_samples_component__ = __webpack_require__(554);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__components_add_edit_sample_add_edit_sample_component__ = __webpack_require__(553);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return SamplesRoutingModule; });
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




const routes = [
    { path: '', component: __WEBPACK_IMPORTED_MODULE_2__components_samples_component__["a" /* SamplesComponent */] },
    { path: 'samples/add', component: __WEBPACK_IMPORTED_MODULE_3__components_add_edit_sample_add_edit_sample_component__["a" /* AddEditSampleComponent */] }
];
let SamplesRoutingModule = class SamplesRoutingModule {
};
SamplesRoutingModule = __decorate([
    __webpack_require__.i(__WEBPACK_IMPORTED_MODULE_0__angular_core__["b" /* NgModule */])({
        imports: [__WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* RouterModule */].forChild(routes)],
        exports: [__WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* RouterModule */]],
        providers: []
    })
], SamplesRoutingModule);

//# sourceMappingURL=C:/Users/mzaidi/Source/Repos/genebygene2017/FrontEnd/genebygene/src/samples-routing.module.js.map

/***/ }),

/***/ 558:
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__(62)();
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ 559:
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__(62)();
// imports


// module
exports.push([module.i, "", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ 560:
/***/ (function(module, exports) {

module.exports = "<h1>\n  Add New Sample!\n</h1>\n<label for=\"message\" class=\"alert\" [ngClass]=\"{'alert-success': isSucceed && !isNewSample, 'alert-danger': !isSucceed && !isNewSample, 'alert-info': isNewSample }\">{{message}}</label>\n\n<div class=\"panel panel-primary\">\n  <div class=\"panel-heading\">\n    <h3 class=\"panel-title\">Add New Sample</h3>\n  </div>\n  <div class=\"panel-body\">\n    <label for=\"Barcode\">Barcode</label>\n    <input type=\"text\" class=\"form-control\" [(ngModel)]=\"sample.barcode\" />\n    <br>\n    <label for=\"CreatedBy\">CreatedBy</label>\n    <select name=\"CreatedBy\" id=\"CreatedBy\" class=\"form-control\" [(ngModel)]=\"sample.createdBy\">\n      <option *ngFor=\"let user of users; let i = index\" [value]=\"user.userId\">{{user.fullName}}</option>\n    </select>\n    <br>\n    <label for=\"Status\">Status</label>\n    <select name=\"status\" id=\"status\" class=\"form-control\" [(ngModel)]=\"sample.statusId\">\n      <option value=\"0\">Received</option>\n      <option value=\"1\" selected=\"true\">Accessioning</option>\n      <option value=\"2\">In Lab</option>\n      <option value=\"3\">Report Generation</option>\n    </select>\n  <br>\n  <label for=\"CreatedAt\">Created On</label>\n  <label for=\"CreatedAtValue\">{{sample.createdAt | date:'medium'}}</label>\n  <br>\n    <button class=\"pull-right btn btn-primary\" (click)=\"save()\">\n      <span>\n          <i class=\"fa fa-floppy-o\"></i>\n      </span>\n      <span class=\"ng-scope\">Save</span>\n    </button>\n  </div>\n</div>  "

/***/ }),

/***/ 561:
/***/ (function(module, exports) {

module.exports = "<h1>\n  Samples\n</h1>\n<a class=\"btn btn-primary\" [routerLink]=\"['samples/add']\">Add New Sample</a>\n\n<div class=\"panel panel-primary\">\n  <div class=\"panel-heading\">\n    <h3 class=\"panel-title\">Search</h3>\n  </div>\n  <div class=\"panel-body\">\n    <div class=\"form-group col-md-4\">\n      <label class=\"control-label\">First|Last-Name :</label>\n      <input type=\"text\" [(ngModel)]=\"nameSearch\" class=\"form-control ng-pristine ng-valid ng-empty ng-touched\" type=\"text\" id=\"nameSearch\" style=\"width: 100%;\" />\n    </div>\n    <div class=\"form-group col-md-4\">\n      <label class=\"control-label\">Status:</label>\n      <select name=\"status\" id=\"status\" class=\"form-control\" [(ngModel)]=\"statusId\">\n        <option value=\"0\">Received</option>\n        <option value=\"1\">Accessioning</option>\n        <option value=\"2\">In Lab</option>\n        <option value=\"3\">Report Generation</option>\n      </select>\n    </div>\n    <div class=\"form-group col-sm-12\">\n      <button class=\"pull-right btn btn-primary\" style=\"margin-left:10px;\" (click)=\"getSamplesbyName()\">\n          <span>\n              <i class=\"fa fa-search\"></i>\n          </span>\n          <span class=\"ng-scope\">SearchByName</span>\n      </button>\n      <button class=\"pull-right btn btn-primary\" (click)=\"getSamplesbyStatus()\">\n          <span>\n              <i class=\"fa fa-search\"></i>\n          </span>\n          <span class=\"ng-scope\">SearchByStatus</span>\n      </button>\n    </div>\n  </div>\n</div>\n\n<table class=\"table table-hover\">\n  <tbody>\n    <tr>\n      <th>SampleId</th>\n      <th>Barcode</th>\n      <th>Date Created</th>\n      <th>Created By</th>\n      <th>Status</th>\n      <th>Action</th>\n    </tr>\n    <tr *ngFor=\"let sample of samples; let i = index\">\n      <td>{{sample.sampleId}}</td>\n      <td>{{sample.barcode}}</td>\n      <td>{{sample.createdAt | date:'medium'}}</td>\n      <td>{{sample.createdByUser}}</td>\n      <td>{{sample.status}}</td>\n      <td><button type=\"submit\" class=\"btn btn-danger\"><i class=\"fa fa-trash\"></i></button></td>\n    </tr>\n  </tbody>\n</table>"

/***/ })

});
//# sourceMappingURL=0.chunk.js.map