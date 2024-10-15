# Use the official PostgreSQL image as a base
FROM postgres:14

# Optional: Add custom configuration or scripts
# For example, copy custom PostgreSQL config files if needed
# COPY ./my_postgres_config.conf /etc/postgresql/postgresql.conf

# Optional: Run additional setup commands here

# Set the default command (this is inherited from the base image, so not strictly needed)
CMD ["postgres"]
