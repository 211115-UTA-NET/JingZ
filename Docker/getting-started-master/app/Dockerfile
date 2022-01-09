# syntax=docker/dockerfile:1
# FROM establishes the base image - in this case "node" with the 12-alpine tag
FROM node:12-alpine

# RUN declare a set of actions to perform when building the image.
# Here, we're using the apk package manager to add several dependencies
RUN apk add --no-cache python2 g++ make

# WORKDIR set our working directory, 
# Like changing the current working directory in bash termianl
WORKDIR /app

# COPY copies from the Dockerfiles perspective 
# (outside the image, current work directory) 
# to the WORKDIRS perspective inside the image.
COPY . .

# RUN runs more commands from inside the image... equivelent to "dotnet build"
RUN yarn install --production

# CMD executed when the container starts. 
# (has no effect on the building of the image)
CMD ["node", "src/index.js"]