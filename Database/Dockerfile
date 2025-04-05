FROM mcr.microsoft.com/mssql/server:2022-latest
# Change active user to root
USER root 

# Create a config directory
RUN mkdir -p /usr/config

# Set mssql as owner of the app directory
RUN chown mssql /usr/config

# Create a config directory
RUN mkdir -p /usr/config
WORKDIR /usr/config

# Bundle config source
COPY ./docker/. /usr/config

# Grant permissions for to our scripts to be executable
RUN chmod +x /usr/config/entrypoint.sh
RUN chmod +x /usr/config/configure-db.sh

ENTRYPOINT ["/usr/config/entrypoint.sh"]