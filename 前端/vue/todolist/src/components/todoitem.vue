<template>
  <li class="item" @click="handleDel">{{content}}</li>
</template>

<script>
export default {
  props: ['content', 'index'],
  methods: {
    handleDel () {
      this.$emit('delete', this.index)
    }
  }
}
</script>

<style>
  .item{
    color: red;
  }
</style>
