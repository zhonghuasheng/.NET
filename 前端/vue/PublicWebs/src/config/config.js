const IsDEV= process.env.NODE_ENV === 'development';
const IsTEST= process.env.NODE_ENV === 'test';

export default {
    apiHost: IsDEV ? 'http://www.dev.com' : ( IsTEST ? 'https://www.test.com' : 'http://www.prod.com'),
};
