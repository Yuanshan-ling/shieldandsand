# 盾与沙｜Unity URP 特效原型

基于 Unity URP 制作的特效练习项目，围绕能量护盾与沙尘流动两类效果，练习 Shader Graph 材质表现与 Shuriken 粒子系统的组合使用。

> **引擎版本：** Unity 6.3 LTS  
> **渲染管线：** URP  
> **核心工具：** Shader Graph、Particle System（Shuriken）  
> **开发语言：** C#

## 演示视频

> 视频演示：待补充  
> 作品集主页：待补充

## 项目内容

### 能量护盾

- 使用 Shader Graph 制作半透明能量护盾材质。
- 通过 Fresnel 边缘光增强护盾轮廓与能量感。
- 结合颜色、透明度与纹理扰动，表现护盾表面的流动效果。
- 将材质参数暴露到 Inspector，便于快速调整视觉风格。

### 沙尘效果

- 使用 Unity Particle System（Shuriken）制作沙尘粒子。
- 通过粒子生命周期、速度、尺寸和透明度控制沙尘的生成与消散。
- 调整粒子运动方向与随机扰动，使沙尘具有自然流动感。
- 将护盾与沙尘放置在同一场景中，观察不同特效之间的层次关系。

## 打开项目

1. Clone 本仓库到本地。
2. 使用 Unity Hub 打开项目根目录。
3. 推荐使用 **Unity 6.3 LTS** 打开。
4. 项目首次打开时会自动尝试载入主场景。
5. 如未自动打开，请手动双击：

   `Assets/Scenes/shieldandsand.unity`

6. 在 Unity Editor 中点击 Play 运行。

## 项目结构

```text
Assets/
├── Scenes/       # 场景文件
├── Materials/    # 护盾等材质资源
├── Shaders/      # Shader Graph 资源
├── Prefabs/      # 特效相关预制体
├── Textures/     # 噪声、遮罩等贴图
├── Script/       # 场景或交互脚本
└── Editor/       # 默认打开主场景的编辑器脚本

