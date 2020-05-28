import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'

Vue.use(Router)

export default new Router({
    routes: [
        {
            path: '/',
            name: 'home',
            component: Home
        },
        {
            path: '/hr/mescollect',
            name: 'mescollect',
            component: () => import('./components/hr/mescollect.vue')
        },
        {
            path: '/hr/denyOffer',
            name: 'denyOffer',
            component: () => import('./components/hr/denyOffer.vue')
        },
        {
            path: '/hr/success',
            name: 'success',
            component: () => import('./components/hr/success.vue')
        },
        {
            path: '/mymaps',
            name: 'mymaps',
            component: () => import('./components/mymaps.vue')
        },
        {
            path: '/mytest',
            name: 'mytest',
            component: () => import('./components/mytest.vue')
        }
    ]
})
