<template>
    <div class="mytest">
        <p>实验室</p>
        <iframe class="test" name="writedog" src="https://writedog-test.mingyuanyun.com/sso-login.aspx?returnUrl=/writedog/request.html&nav=0&Mode=1&stockID=90ee7f0e-0634-48ad-9198-b7cb257d011a&token=kK8sOJeVnQoiqteeFlyCVEuKqve6qPUOuvS%2bQA%2bnrNM%3d&btnType=1"></iframe>
        <button @click="cli">点击</button>
    </div>
</template>

<script>
    export default {
        name: "mytest",
        props: {},
        data() {
            return {}
        },
        methods: {
            cli(){
                try{
                    window.frames["writedog"].postMessage({type:"save"},"https://writedog-test.mingyuanyun.com");
                    // var iframWindow = document.getElementsByName("writedog")[0].contentWindow;
                    // iframWindow.postMessage("aaaa", "https://www.baidu.com/");
                    console.log("出库调用子窗体成功", "777");
                } catch (e) {
                    console.log("出库调用子窗体失败", e);
                }
            }
        },
        mounted() {

        }
    }
</script>

<style lang="scss" scoped>
.test{
    width: 500px;
    height: 700px;
}
</style>