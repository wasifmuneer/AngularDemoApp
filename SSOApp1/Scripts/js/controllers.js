/**
 * INSPINIA - Responsive Admin Theme
 *
 */

/**
 * MainCtrl - controller
 */
function MainCtrl() {

    this.userName = 'Example user';
    this.helloText = 'Welcome in SeedProject';
    this.descriptionText = 'This is Project 2 of SSO';

};


angular
    .module('inspinia')
    .controller('MainCtrl', MainCtrl)