import pandas as pd
import json
import argparse

# EXAMPLE: python script_name.py /path/to/aircraft_data.json /path/to/output.csv

# Set up argument parser
parser = argparse.ArgumentParser(description='Convert JSON aircraft data to CSV.')
parser.add_argument('input_file', type=str, help='Path to the input JSON file.')
parser.add_argument('output_file', type=str, help='Path to the output CSV file.')

# Parse the arguments
args = parser.parse_args()

# Read the JSON data from the file
with open(args.input_file, 'r') as file:
    aircraft_data = json.load(file)

# Convert to DataFrame
df = pd.DataFrame(aircraft_data)

# Save to CSV
df.to_csv(args.output_file, index=False)

# Provide the file for download
print(f"CSV file saved to {args.output_file}")