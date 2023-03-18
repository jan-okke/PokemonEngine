using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mesprit : Pokemon
	{
		public override string Name => "Mesprit";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override Stats BaseStats => new Stats(80, 105, 105, 105, 105, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Confusion(), new Moves.Rest() },
			[7] = new List<Move>() { new Moves.Swift() },
			[14] = new List<Move>() { new Moves.Protect() },
			[21] = new List<Move>() { new Moves.Psybeam() },
			[28] = new List<Move>() { new Moves.Imprison() },
			[35] = new List<Move>() { new Moves.Extrasensory() },
			[42] = new List<Move>() { new Moves.Charm() },
			[49] = new List<Move>() { new Moves.Psychic() },
			[56] = new List<Move>() { new Moves.Flatter() },
			[63] = new List<Move>() { new Moves.Futuresight() },
			[70] = new List<Move>() { new Moves.Copycat() },
			[77] = new List<Move>() { new Moves.Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override int Weight => 3;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}