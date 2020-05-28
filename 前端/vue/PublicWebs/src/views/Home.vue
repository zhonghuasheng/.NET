<template>
  <div class="home">
    <p>无次页面</p>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'home',
  components: {
    HelloWorld
  }
}
</script>

<style lang="scss">
  .home{
    p{
      text-align: center;
      margin-top: 100px;
      font-size: 35px;
    }
  }

</style>
