using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magearna : Pokemon
	{
		public override string Name => "Magearna";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Soulheart() };
		public override Stats BaseStats => new Stats(80, 95, 115, 130, 115, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Gyroball(), new Moves.Helpinghand() },
			[6] = new List<Move>() { new Moves.Defensecurl() },
			[12] = new List<Move>() { new Moves.Rollout() },
			[18] = new List<Move>() { new Moves.Irondefense() },
			[24] = new List<Move>() { new Moves.Gearup() },
			[30] = new List<Move>() { new Moves.Psybeam() },
			[36] = new List<Move>() { new Moves.Aurorabeam() },
			[42] = new List<Move>() { new Moves.Mindreader() },
			[48] = new List<Move>() { new Moves.Shiftgear() },
			[54] = new List<Move>() { new Moves.Craftyshield() },
			[60] = new List<Move>() { new Moves.Ironhead() },
			[66] = new List<Move>() { new Moves.Aurasphere() },
			[72] = new List<Move>() { new Moves.Flashcannon() },
			[78] = new List<Move>() { new Moves.Painsplit() },
			[84] = new List<Move>() { new Moves.Zapcannon() },
			[90] = new List<Move>() { new Moves.Fleurcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Mistyexplosion(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Voltswitch(), new Moves.Zenheadbutt() };
		public override int Weight => 805;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}